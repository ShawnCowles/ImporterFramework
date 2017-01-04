using System;
using System.Xml.Linq;
using ImporterFramework.Data;
using TiledSharp;

namespace ImporterFramework.Workers
{
    public abstract class AbstractWorker<T_M> where T_M : ImportContext
    {
        protected AbstractWorker()
        {
        }

        public abstract string Name { get; }
        
        public abstract WorkResult DoWork(T_M importContext);

        protected WorkResult ReportOnException(Exception ex)
        {
            var message = "Exception:\n";
            var currentException = ex;

            while (currentException != null)
            {
                message += $"{currentException.Message}\n";

                if (currentException.InnerException == null)
                {
                    message += $"{currentException.StackTrace}\n";
                }

                currentException = currentException.InnerException;
            }

            return new WorkResult(Name, false, message);
        }

        protected string GetProperty(TmxObject obj, string propertyName)
        {
            if (!obj.Properties.ContainsKey(propertyName))
            {
                throw new ImportException($"Object '{obj.Name}' is missing property '{propertyName}'");
            }

            return obj.Properties[propertyName];
        }

        protected int GetIntProperty(TmxObject obj, string propertyName)
        {
            var val = GetProperty(obj, propertyName);

            int i;

            if (int.TryParse(val, out i))
            {
                return i;
            }

            throw new ImportException($"Property '{propertyName}' on object '{obj.Name}' is not an int.");
        }

        protected double GetDoubleProperty(TmxObject obj, string propertyName)
        {
            var val = GetProperty(obj, propertyName);

            double d;

            if (double.TryParse(val, out d))
            {
                return d;
            }

            throw new ImportException($"Property '{propertyName}' on object '{obj.Name}' is not a double.");
        }

        protected T GetEnumProperty<T>(TmxObject obj, string propertyName) where T : struct, IConvertible
        {
            if (!typeof(T).IsEnum)
            {
                throw new ArgumentException("Provided type must be an enumerated type.");
            }

            var val = GetProperty(obj, propertyName);

            T res;

            if (Enum.TryParse<T>(val, out res))
            {
                return res;
            }

            throw new ImportException($"Property '{propertyName}' on object '{obj.Name}' is not a {typeof(T).Name}.");
        }

        protected bool GetBoolProperty(TmxObject obj, string propertyName)
        {
            var val = GetProperty(obj, propertyName);

            bool b;

            if (bool.TryParse(val, out b))
            {
                return b;
            }

            throw new ImportException($"Property '{propertyName}' on object '{obj.Name}' is not a bool.");
        }

        protected string GetProperty(TmxMap map, string propertyName)
        {
            if (!map.Properties.ContainsKey(propertyName))
            {
                throw new ImportException($"Map is missing property '{propertyName}'");
            }

            return map.Properties[propertyName];
        }

        protected int GetIntProperty(TmxMap map, string propertyName)
        {
            var val = GetProperty(map, propertyName);

            int i;

            if (int.TryParse(val, out i))
            {
                return i;
            }

            throw new ImportException($"Property '{propertyName}' on map is not an int.");
        }

        protected double GetDoubleProperty(TmxMap map, string propertyName)
        {
            var val = GetProperty(map, propertyName);

            double d;

            if (double.TryParse(val, out d))
            {
                return d;
            }

            throw new ImportException($"Property '{propertyName}' on map is not a double.");
        }

        protected T GetEnumProperty<T>(TmxMap map, string propertyName) where T : struct, IConvertible
        {
            if (!typeof(T).IsEnum)
            {
                throw new ArgumentException("Provided type must be an enumerated type.");
            }

            var val = GetProperty(map, propertyName);

            T res;

            if (Enum.TryParse<T>(val, out res))
            {
                return res;
            }

            throw new ImportException($"Property '{propertyName}' on map is not a {typeof(T).Name}.");
        }

        protected bool GetBoolProperty(TmxMap map, string propertyName)
        {
            var val = GetProperty(map, propertyName);

            bool b;

            if (bool.TryParse(val, out b))
            {
                return b;
            }

            throw new ImportException($"Property '{propertyName}' on map is not a bool.");
        }

        protected string GetAttribute(XElement element, string attributeName)
        {
            var attribute = element.Attribute(attributeName);

            if (attribute == null)
            {
                throw new ImportException($"XElement '{element.Name}' is missing attribute '{attributeName}'");
            }

            return attribute.Value;
        }

        protected double GetDoubleAttribute(XElement element, string attributeName)
        {
            var val = GetAttribute(element, attributeName);

            double d;

            if (double.TryParse(val, out d))
            {
                return d;
            }

            throw new ImportException($"Property '{attributeName}' on element '{element.Name}' is not a double.");
        }
    }
}