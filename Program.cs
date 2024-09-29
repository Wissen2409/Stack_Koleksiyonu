
// dün queue koleksiyonunu inceledik. FIFO prensibine sahipti.

// bugün, bu koleksiyonun tam tersi çalışan bir başka koleksiyonu inceleyeceğiz.

// Koleksiyonumuzun ismi : Stack

// Tanımlama

using System.Collections;

Stack stack= new Stack();

// Stack koleksiyonumuza yeni bir eleman eklemek
stack.Push("Yük 1");
stack.Push("Yük 2");
stack.Push("Yük 3");
stack.Push("Yük 4");
stack.Push("Yük 5");
stack.Push("Yük 6");
stack.Push("Yük 7");
stack.Push("Yük 8");
stack.Push("Yük 9");
stack.Push("Yük 10");
stack.Push("Yük 11");
stack.Push("Yük 12");

// Stack LIFO(Last In First out)(Son giren ilk çıkar prensibi) çalışan bir koleksiyondur. 

// Bu koleksiyonu, TIR dorsesi yükleme işlemine benzetebilirsiniz. Tırlar arka taraftan yüklenir.

// Ilk koyulan yükler, her zaman en son çıkar.
// Son koyulan yükler her zaman ilk çıkar

// Peek fonksiyonu silinmek için sırasını  bekleyen item'i size döndürür. Ancak silmez.

string silinmekUzereBekleyen = stack.Peek().ToString();
Console.WriteLine(silinmekUzereBekleyen);


// Stack koleksiyonu içerisinden elemanları LIFO prensibine göre silmek

// Bunun için bir döngü kullanalım
int donguDegisken = stack.Count;
for (int i=0; i<donguDegisken;i++){

    Console.WriteLine("Stack koleksiyonundan bir eleman çıkartmak için enter tuşuna basınız");
    Console.ReadLine();
   string silinen =  stack.Pop().ToString();
   Console.WriteLine("Silinen : {0} - Koleksiyon sayısı  {1}",silinen,stack.Count);
  
}





