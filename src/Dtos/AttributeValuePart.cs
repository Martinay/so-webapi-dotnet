﻿namespace Sample.Dtos
{
    public class AttributeValuePart
    {
        public AttributeValuePart(string name, string value, bool isDescription = false)
            : this(name)
        {
            if (isDescription)
                Description = value;
            else
                Value = value;
        }

        public AttributeValuePart(string name, string language, string value)
            : this(name)
        {
            Language = language;
            Value = value;
        }

        public AttributeValuePart(string name, int index, string value)
            : this(name)
        {
            Index = index;
            Value = value;
        }

        public AttributeValuePart(string name, int index, string language, string value)
            : this(name)
        {
            Index = index;
            Language = language;
            Value = value;
        }

        private AttributeValuePart(string name)
        {
            Name = name;
        }

        /// <summary>
        /// Key part name.
        /// </summary>
        public string Name { get; }

        public string? Language { get; }
        public int? Index { get; }

        public string? Value { get; }

        /// <summary>
        /// Optional and only for identifying values.
        /// </summary>
        public string? Description { get; }
    }
}