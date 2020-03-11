using System;
using Unity;

namespace DIPractice
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            IUnityContainer unityContainer = new UnityContainer();
            unityContainer.RegisterType<IBook, ABook>();//註冊依賴物件
            IBook output = unityContainer.Resolve<IBook>();//返回呼叫者
            //取代了WriteBook output = new WriteBook(new ABook());
            Console.WriteLine(output.Write());
        }
    }
}