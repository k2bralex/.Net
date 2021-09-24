using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Example example = new Example();
            ////if (example.FirstName == null)
            ////{
            ////    example.FirstName = "John";
            ////}
            //Console.WriteLine($"Имя: { example.FirstName ?? "John"} /  nНомер: { example.Num}");


            //1.	Описать структуру Article, содержащую следующие
            //поля: код товара; название товара; цену товара.

            //Article prod1 = new Article(2020, "Beer", 20.2);
            //Console.WriteLine(prod1.Print());


            //2.Описать структуру Client содержащую поля: код
            //    клиента; ФИО; адрес; телефон; количество заказов
            //осуществленных клиентом; общая сумма заказов
            //клиента.

            //Client client1 = new Client(1001, "John", 999888777, 23, 909.32);


            //3.Описать структуру RequestItem содержащую поля:
            //товар; количество единиц товара.

            //RequestItem newRequestItem = new RequestItem(new Article(2020, 20.2), 2);
            //Console.WriteLine(newRequestItem.Print());


            //4.Описать структуру Request содержащую поля: код
            //    заказа; клиент; дата заказа; перечень заказанных товаров;
            //сумма заказа(реализовать вычисляемым свойством).


            //Request req1 = new Request(12345);
            //req1.ProducListCreate(newRequestItem);
            //req1.Check();
            //req1.addClient(client1);
            //req1.productListPrint();
            //Console.WriteLine(req1.Print());

            //5.Описать перечисление ArticleType определяющее
            //типы товаров, и добавить соответствующее поле
            //    в структуру Article из задания №1.

            //6.Описать перечисление ClientType определяющее
            //важность клиента, и добавить соответствующее поле
            //    в структуру Client из задания №2.

            //7.Описать перечисление PayType определяющее форму
            //оплаты клиентом заказа, и добавить соответствующее
            //поле в структуру Request из задания №4.





            //8.Придумать класс, описывающий студента. Преду -
            //    смотреть в нем следующие моменты: фамилия, имя,
            //отчество, группа, возраст, массив(зубчатый) оценок по
            //    программированию, администрированию и дизайну.
            //    А также добавить методы по работе с перечисленными
                // данными: возможность установки/получения оцен-
                //ки, получение среднего балла по заданному предмету,
                //распечатка данных о студенте.


                Student student1 = new Student();
                int grade;
                student1.getGrade(out grade);
                Console.WriteLine(grade);
                student1.Print();



            Console.ReadLine();
        }
    }

    enum PayType
    {
        CreditCard, Cash, PayPal
    }

    public struct Request
    {
        private PayType _payType;
        private int _requestCode;
        public DateTime _date;
        private Client _client;
        private List<RequestItem> _productList;
        private double _check;

        public Request(int requestCode)
        {
            _requestCode = requestCode;
            _productList = new List<RequestItem>();
            _check = 0.0;
            _client = new Client();
            _date = DateTime.Today;
            Random payTypeRandom = new Random();
            _payType = (PayType)payTypeRandom.Next(1, 3);
        }

        public void addClient(Client client)
        {
            _client = client;
        }

        public void ProducListCreate(RequestItem rqItem)
        {
            _productList.Add(rqItem);
        }

        public void Check()
        {
            double Sum=0;
            foreach (var i in _productList)
            {
                Sum += i._position._price*i._quantity;
            }
            _check = Sum;
        }

        public void productListPrint()
        {
            foreach (var i in _productList)
            {
                Console.WriteLine(i.Print());
            }
        }

        public string Print()
        {
            return $"REQUEST CODE: {_requestCode}\n  Date: {_date}\n{_client.Print()}\nPay Type: {_payType}\nCheck sum: {_check}";
        }

    }


    public struct RequestItem
    {
        public Article _position;
        public int _quantity;

        public RequestItem(Article article, int qty)
        {
            _position = article;
            _quantity = qty;
        }

        public string Print()
        {
            return $"{_position.Print() }\nQuiantity: {_quantity} ";
        }
    }

    enum productType
    {
        Beer, Brad, Potatos, Milk, Sugar
    }
    public struct Article
    {
        private int _code;
        private productType _name;
        public double _price;

        public Article(int code, double price)
        {
            _code = code;
            Random productType = new Random();
            _name = (productType)productType.Next(1, 5);
            _price = price;
        }

        public string Print()
        {
            return $"Code: {_code}\nName: {_name}\nPrice: {_price}";
        }
    }

    enum ClientRank
    {
        Beginner, Middle, TopBayer
    }

    public struct Client
    {
        private ClientRank _rank;
        private int _code;
        private string _name;
        private ulong _phone;
        private int _ordersQuantity;
        private double _totalAmount;

        public Client(int code, string name, ulong phone, int ordersQuantity, double totalAmount)
        {
            _code = code;
            _name = name;
            _phone = phone;
            _ordersQuantity = ordersQuantity;
            _totalAmount = totalAmount;
            Random clientRankRandom = new Random();
            _rank = (ClientRank)clientRankRandom.Next(1, 3);
        }

        public string Print()
        {
            return $"CLIENT RANK: {_rank}\nCode: {_code}\nName: {_name}\nPhone: {_phone}\nOrders quantity: {_ordersQuantity}\nAmount: {_totalAmount}$";
        }

    }

}
