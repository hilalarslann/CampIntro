using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    //Generic Class
    //<T> bana bir tip ver demek ben aşağıyı ona göre yapılandıracağım.
    //Ben MyListimde T ile çalışacağım.Buraya başka isimde girebiliriz ama generic bir tip alıyorsa biz T yazarız, typtan gelir.
    class MyList<T>
    {
        T[] items;

        //Constructor
        public MyList()
        {
            items = new T[0];
        }

        //Programcı bana T olarak ne verirse onu kabul ediyorum.
        public void Add(T item)
        {
            
        }
    }
}
