﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2 {
  class HTML : Document {
    string DocumentHTMLClassesUsed;
    int DocumentHTMLStringCount;

    public HTML(string DocumentTitle, string DocumentAuthor, string DocumentKeyWord, string DocumentPath,
      string DocumentTopic) {
      this.DocumentTitle = DocumentTitle;
      this.DocumentAuthor = DocumentAuthor;
      this.DocumentKeyWord = DocumentKeyWord;
      this.DocumentPath = DocumentPath;
      this.DocumentTopic = DocumentTopic;

      Console.WriteLine("Введите количество строк: ");
      DocumentHTMLStringCount = int.Parse(Console.ReadLine());

      Console.WriteLine("Введите используемые классы: ");
      DocumentHTMLClassesUsed = Console.ReadLine();
    }

    public override void DocumentInfo() {
      Console.WriteLine($"\nИмя: {DocumentTitle}\nАвтор: {DocumentAuthor}\nКлючевые слова: {DocumentKeyWord}\n" +
        $"Путь к файлу: {DocumentPath}\nТема документа: {DocumentTopic}\nИспользуемые классы: {DocumentHTMLClassesUsed}\n" +
        $"Количество строк: {DocumentHTMLStringCount}\n");
    }
  }
}