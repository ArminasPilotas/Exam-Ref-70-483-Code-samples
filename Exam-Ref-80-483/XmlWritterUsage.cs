using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Exam_Ref_80_483
{
    public class XmlWritterUsage
    {
        public string ReadToXml(Book book)
        {
            var stringWritter = new StringWriter();

            using (XmlWriter writter = XmlWriter.Create(stringWritter))
            {
                writter.WriteStartElement("book");
                writter.WriteElementString("author", book.Author);
                writter.WriteElementString("title", book.Title);
                writter.WriteElementString("price", book.Price.ToString());
                writter.WriteEndElement();
                writter.Flush();
            }

            return stringWritter.ToString();
        }
    }

    public class Book
    {
        public string Author { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }

        public Book (string author, string title, decimal price)
        {
            Author = author;
            Title = title;
            Price = price;
        }
    }
}
