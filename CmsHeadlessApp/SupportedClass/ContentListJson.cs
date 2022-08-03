using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CmsHeadlessApp.SupportedClass
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<List<Root>>(myJsonResponse);
    public class Attribute
    {
        public int AttributesId { get; set; }
        public string AttributeName { get; set; }
        public string AttributeValue { get; set; }
        public object ContentAttributes { get; set; }
        public object AttributesTypology { get; set; }
    }

    public class Category
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int? CategoryParentId { get; set; }
        public string Media { get; set; }
        public DateTime CreationDate { get; set; }
        public object ContentCategory { get; set; }
    }

    public class ContentList
    {
        public string MediaWithPath { get; set; }
        public string EmailUser { get; set; }
        public List<Attribute> Attributes { get; set; }
        public List<Tag> Tag { get; set; }
        public List<Category> Category { get; set; }
        public List<string> Location { get; set; }
        public int ContentId { get; set; }
        public string Title { get; set; }
        public object Media { get; set; }
        public object Description { get; set; }
        public DateTime InsertionDate { get; set; }
        public string Text { get; set; }
        public string UserId { get; set; }
        public DateTime? LastEdit { get; set; }
        public DateTime? PubblicationDate { get; set; }
        public object ContentAttributes { get; set; }
        public object ContentCategory { get; set; }
        public object ContentTag { get; set; }
        public object User { get; set; }
        public object ContentLocation { get; set; }
    }

    public class Tag
    {
        public int TagId { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
    }
}
