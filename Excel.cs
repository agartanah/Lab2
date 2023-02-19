using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2 {
  class Excel : Document {
    int DocumentExcelRowCount, DocumentExcelColumnCount;

    public Excel(string DocumentTitle, string DocumentAuthor, string DocumentKeyWord, string DocumentPath,
      string DocumentTopic) {
      this.DocumentTitle = DocumentTitle;
      this.DocumentAuthor = DocumentAuthor;
      this.DocumentKeyWord = DocumentKeyWord;
      this.DocumentPath = DocumentPath;
      this.DocumentTopic = DocumentTopic;

      Console.WriteLine("Введите количество столбцов: ");
      DocumentExcelColumnCount = int.Parse(Console.ReadLine());

      Console.WriteLine("Введите количество строк: ");
      DocumentExcelRowCount = int.Parse(Console.ReadLine());
    }

    public override void DocumentInfo() {
      Console.WriteLine($"\nИмя: {DocumentTitle}\nАвтор: {DocumentAuthor}\nКлючевые слова: {DocumentKeyWord}\n" +
        $"Путь к файлу: {DocumentPath}\nТема документа: {DocumentTopic}\nКоличество строк: {DocumentExcelRowCount}\n" +
        $"Количество столбцов: {DocumentExcelColumnCount}\n");
    }
  }
}
