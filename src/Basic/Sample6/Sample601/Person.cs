using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample601
{
    class Person
    {
        // 名前
        public string name = "";

        // 年齢
        public int age = 0;

        // 情報の表示(メソッド)
        public void showAgeAndName()
        {
            Console.WriteLine("名前:{0} 年齢:{1}", name, age);
        }

        // 情報の設定
        public void SetAgeAndName(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
    }
}
