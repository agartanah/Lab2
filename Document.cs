using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2 {
  class Document {
    public string DocumentTitle, DocumentAuthor,
      DocumentKeyWord, DocumentPath, DocumentTopic;

    public virtual void DocumentInfo() {
      Console.WriteLine($"Title: {DocumentTitle}\nAuthor: {DocumentAuthor}\nKey word: {DocumentKeyWord}\n" +
        $"Path: {DocumentPath}\nTopic: {DocumentTopic}\n");
    }
  }
}
