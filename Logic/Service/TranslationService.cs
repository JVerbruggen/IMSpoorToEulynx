using Models.Translation;
using Services.TopoModels;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;
using Models.TopoModels;
using System.Reflection;

namespace Logic.Managers
{
    public class TranslationService : ITranslationService<Services.TopoModels.IMSpoor, Services.TopoModels.RailTopoModel>
    {

        private void assignAttributeToObject(object assignee, object value, String attributeName, String attributeType)
        {
            assignee.GetType().GetProperty(attributeName).SetValue(assignee, value);
        }

        private void assignElementAttributeToObject(object assignee, object value, String attributeName, String attributeType)
        {
            if(assignee.GetType().GetProperty(attributeName) != null)
            {
                assignAttributeToObject(assignee, value, attributeName, attributeType);
            }
            else if(assignee.GetType().GetProperty("Item") != null)
            {
                assignee.GetType().GetProperty("Item").SetValue(assignee, value);
            }
            else if(assignee.GetType().GetProperty("Items") != null)
            {
                assignee.GetType().GetProperty("Items").SetValue(assignee, value);
            }
        }

        /// <summary>
        /// Transform an xElement to an object found in the imported IMSpoor XSD using reflection
        /// </summary>
        private object transformToObject(XElement xElement, string typeName)
        {
            IEnumerable<XElement> elements = xElement.Elements();
            
            Type type = Type.GetType("Models.TopoModels." + typeName + ",Models");
            MemberInfo[] members = type.GetMembers();

            object elementObj = Activator.CreateInstance(type);

            foreach (XElement element in elements) // Element Read from XML File
            {
                foreach(MemberInfo member in members) // Member (method/field/property) of current element model (XSD)
                {
                    foreach(CustomAttributeData attribute in member.CustomAttributes) // Specification of each attribute
                    {
                        switch (attribute.AttributeType.Name)
                        {
                            case "XmlElementAttribute":
                                if (attribute.ConstructorArguments.Count == 2)
                                {
                                    string attributeName = (String)attribute.ConstructorArguments[0].Value;
                                    string attributeType = ((Type)attribute.ConstructorArguments[1].Value).Name;

                                    if (attributeName == element.Name.LocalName)
                                    {
                                        object value = transformToObject(element, attributeType);
                                        assignElementAttributeToObject(elementObj, value, attributeName, attributeType);
                                    }
                                }
                                else
                                {

                                }
                                break;
                            case "XmlAttributeAttribute":
                                //throw new NotImplementedException();

                                break;
                            case "XmlIgnoreAttribute":
                                //throw new NotImplementedException();

                                break;
                        }
                    }
                    
                    if(member.Name == element.Name.LocalName)
                    {
                        if(member.Name == "PassageRefs")
                        {
                            var a = 1;
                        }
                        else
                        {
                            var b = 2;
                        }

                        string memberTypeName = member.Name;

                        object value;
                        if (memberTypeName == "string" || memberTypeName == "int" || memberTypeName == "bool" || memberTypeName == "double")
                        {
                            value = element.Value;
                        }
                        else
                        {
                            value = transformToObject(element, element.Name.LocalName);
                        }

                        assignAttributeToObject(elementObj, value, member.ReflectedType.Name, member.Name);
                    }
                }
            }

            return elementObj;
        }

        public Services.TopoModels.RailTopoModel Translate(Services.TopoModels.IMSpoor imSpoor)
        {
            XElement xElement = imSpoor.xElement;

            var result = transformToObject(xElement, xElement.Name.LocalName);

            return null;
        }

    }
}
