using System;

namespace GenericsIntro
{
    //Generic Class
    //<T> bana bir tip ver demek ben aşağıyı ona göre yapılandıracağım.
    //Ben MyListimde T ile çalışacağım.Bu T bir class, string bir çok şey olabilir.
    //Buraya başka isimde girebiliriz ama generic bir tip alıyorsa biz T yazarız, typtan gelir.
    class MyList<T>
    {
        T[] items;
        int count;

        //Constructor
        public MyList()
        {
            //sıfır elemanlı dizi oluşturduk
            items = new T[0];
        }

        //2 - 4 - 8 - 16 - 32

        //Programcı bana T olarak ne verirse onu kabul ediyorum.
        public void Add(T item)
        {
            //itemsın referansını geçici diziye verdik.
            T[] tempArray = items;
            items = new T[items.Length + 1];

            //burada önceki elemanlarımızı geçici diziden aldık

            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }
            //yeni gelen itemı dizimizin son elemanına ekledik.
            items[items.Length - 1] = item;
        }

        public int Count
        {
            get { return items.Length; }
        }

        public T[] Items
        {
            get { return items; }
        }
    }
}
