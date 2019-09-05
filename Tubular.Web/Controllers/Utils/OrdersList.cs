using System;
using System.Collections.Generic;

namespace Tubular.Web.Utils
{
    public static class OrdersList
    {
        public static List<Order> Orders = new List<Order>()
        {
           new Order(1,"Oxxo",Convert.ToDateTime("2016-11-05T19:00:00"),"Guadalajara, JAL, Mexico",95.00, false),
           new Order(2,"Super La Playa",Convert.ToDateTime("2016-11-02T19:00:00"),"Los Angeles, CA, USA",5.00,false),
           new Order(3,"Unosquare LLC",Convert.ToDateTime("2016-11-04T19:00:00"),"Guadalajara, JAL, Mexico",36.00,false),
           new Order(4,"Microsoft",Convert.ToDateTime("2016-11-11T19:00:00"),"Leon, GTO, Mexico",111.00,false),
           new Order(5,"Unosquare LLC",Convert.ToDateTime("2016-11-07T19:00:00"),"Guadalajara, JAL, Mexico",42.00,true),
           new Order(6,"Microsoft",Convert.ToDateTime("2016-11-08T19:00:00"),"Leon, GTO, Mexico",6.00,false),
new Order(7,"Advanced Technology Systems",Convert.ToDateTime("2016-11-08T19:00:00"),"Guadalajara, JAL, Mexico",97.00,false),
new Order(8,"Super La Playa",Convert.ToDateTime("2016-11-06T19:00:00"),"Portland, OR, USA",1.00,true),
new Order(9,"Microsoft",Convert.ToDateTime("2016-11-09T19:00:00"),"Portland, OR, USA",68.00,true),
new Order(10,"Microsoft",Convert.ToDateTime("2016-11-09T19:00:00"),"Guadalajara, JAL, Mexico",16.00,false),
new Order(11,"Advanced Technology Systems",Convert.ToDateTime("2016-11-08T19:00:00"),"Guadalajara, JAL, Mexico",0.00,false),
new Order(12,"Advanced Technology Systems",Convert.ToDateTime("2016-11-04T19:00:00"),"Leon, GTO, Mexico",25.00,false),
new Order(13,"Vesta",Convert.ToDateTime("2016-11-07T19:00:00"),"Portland, OR, USA",13.00,true),
new Order(14,"Super La Playa",Convert.ToDateTime("2016-11-03T19:00:00"),"Los Angeles, CA, USA",92.00,false),
new Order(15,"Microsoft",Convert.ToDateTime("2016-11-08T19:00:00"),"Leon, GTO, Mexico",41.00,false),
new Order(16,"Vesta",Convert.ToDateTime("2016-11-03T19:00:00"),"Leon, GTO, Mexico",8.00,false),
new Order(17,"Advanced Technology Systems",Convert.ToDateTime("2016-11-03T19:00:00"),"Guadalajara, JAL, Mexico",61.00,true),
new Order(18,"Oxxo",Convert.ToDateTime("2016-11-09T19:00:00"),"Portland, OR, USA",63.00,true),
new Order(19,"Advanced Technology Systems",Convert.ToDateTime("2016-11-02T19:00:00"),"Portland, OR, USA",174.00,true),
new Order(20,"Microsoft",Convert.ToDateTime("2016-11-10T19:00:00"),"Guadalajara, JAL, Mexico",45.00,true),
new Order(21,"Oxxo",Convert.ToDateTime("2016-11-07T19:00:00"),"Portland, OR, USA",68.00,false),
new Order(22,"Oxxo",Convert.ToDateTime("2016-11-04T19:00:00"),"Guadalajara, JAL, Mexico",162.00,true),
new Order(23,"Oxxo",Convert.ToDateTime("2016-11-09T19:00:00"),"Guadalajara, JAL, Mexico",22.00,false),
new Order(24,"Super La Playa",Convert.ToDateTime("2016-11-04T19:00:00"),"Los Angeles, CA, USA",27.00,false),
new Order(25,"Advanced Technology Systems",Convert.ToDateTime("2016-11-05T19:00:00"),"Guadalajara, JAL, Mexico",19.00,false),
new Order(26,"Unosquare LLC",Convert.ToDateTime("2016-11-04T19:00:00"),"Guadalajara, JAL, Mexico",0.00,true),
new Order(27,"Super La Playa",Convert.ToDateTime("2016-11-05T19:00:00"),"Leon, GTO, Mexico",6.00,false),
new Order(28,"Microsoft",Convert.ToDateTime("2016-11-11T19:00:00"),"Leon, GTO, Mexico",70.00,false),
new Order(29,"Unosquare LLC",Convert.ToDateTime("2016-11-04T19:00:00"),"Los Angeles, CA, USA",0.00,true),
new Order(30,"Advanced Technology Systems",Convert.ToDateTime("2016-11-10T19:00:00"),"Guadalajara, JAL, Mexico",86.00,false),
new Order(31,"Unosquare LLC",Convert.ToDateTime("2016-11-11T19:00:00"),"Guadalajara, JAL, Mexico",38.00,false),
new Order(32,"Advanced Technology Systems",Convert.ToDateTime("2016-11-05T19:00:00"),"Portland, OR, USA",146.00,false),
new Order(33,"Vesta",Convert.ToDateTime("2016-11-10T19:00:00"),"Portland, OR, USA",24.00,false),
new Order(34,"Unosquare LLC",Convert.ToDateTime("2016-11-03T19:00:00"),"Guadalajara, JAL, Mexico",25.00,true),
new Order(35,"Vesta",Convert.ToDateTime("2016-11-02T19:00:00"),"Leon, GTO, Mexico",100.00,false),
new Order(36,"Microsoft",Convert.ToDateTime("2016-11-07T19:00:00"),"Portland, OR, USA",63.00,false),
new Order(37,"Microsoft",Convert.ToDateTime("2016-11-11T19:00:00"),"Guadalajara, JAL, Mexico",124.00,false),
new Order(38,"Vesta",Convert.ToDateTime("2016-11-09T19:00:00"),"Los Angeles, CA, USA",56.00,false),
new Order(39,"Super La Playa",Convert.ToDateTime("2016-11-05T19:00:00"),"Los Angeles, CA, USA",36.00,true),
new Order(40,"Advanced Technology Systems",Convert.ToDateTime("2016-11-11T19:00:00"),"Guadalajara, JAL, Mexico",42.00,false),
new Order(41,"Unosquare LLC",Convert.ToDateTime("2016-11-09T19:00:00"),"Los Angeles, CA, USA",128.00,true),
new Order(42,"Super La Playa",Convert.ToDateTime("2016-11-04T19:00:00"),"Guadalajara, JAL, Mexico",85.00,false),
new Order(43,"Super La Playa",Convert.ToDateTime("2016-11-03T19:00:00"),"Los Angeles, CA, USA",67.00,false),
new Order(44,"Super La Playa",Convert.ToDateTime("2016-11-11T19:00:00"),"Guadalajara, JAL, Mexico",0.00,false),
new Order(45,"Vesta",Convert.ToDateTime("2016-11-08T19:00:00"),"Los Angeles, CA, USA",120.00,false),
new Order(46,"Advanced Technology Systems",Convert.ToDateTime("2016-11-10T19:00:00"),"Los Angeles, CA, USA",72.00,false),
new Order(47,"Unosquare LLC",Convert.ToDateTime("2016-11-08T19:00:00"),"Leon, GTO, Mexico",49.00,false),
new Order(48,"Super La Playa",Convert.ToDateTime("2016-11-02T19:00:00"),"Los Angeles, CA, USA",0.00,false),
new Order(49,"Oxxo",Convert.ToDateTime("2016-11-09T19:00:00"),"Leon, GTO, Mexico",25.00,false),
new Order(50,"Oxxo",Convert.ToDateTime("2016-11-06T19:00:00"),"Leon, GTO, Mexico",42.00,true),
new Order(51,"Unosquare LLC",Convert.ToDateTime("2016-11-05T19:00:00"),"Los Angeles, CA, USA",76.00,true),
new Order(52,"Advanced Technology Systems",Convert.ToDateTime("2016-11-09T19:00:00"),"Portland, OR, USA",64.00,false),
new Order(53,"Advanced Technology Systems",Convert.ToDateTime("2016-11-02T19:00:00"),"Los Angeles, CA, USA",87.00,false),
new Order(54,"Super La Playa",Convert.ToDateTime("2016-11-02T19:00:00"),"Los Angeles, CA, USA",27.00,false),
new Order(55,"Advanced Technology Systems",Convert.ToDateTime("2016-11-02T19:00:00"),"Los Angeles, CA, USA",81.00,true),
new Order(56,"Unosquare LLC",Convert.ToDateTime("2016-11-08T19:00:00"),"Los Angeles, CA, USA",144.00,true),
new Order(57,"Unosquare LLC",Convert.ToDateTime("2016-11-03T19:00:00"),"Guadalajara, JAL, Mexico",67.00,false),
new Order(58,"Oxxo",Convert.ToDateTime("2016-11-10T19:00:00"),"Portland, OR, USA",97.00,false),
new Order(59,"Microsoft",Convert.ToDateTime("2016-11-06T19:00:00"),"Leon, GTO, Mexico",35.00,true),
new Order(60,"Unosquare LLC",Convert.ToDateTime("2016-11-05T19:00:00"),"Portland, OR, USA",153.00,true),
new Order(61,"Unosquare LLC",Convert.ToDateTime("2016-11-03T19:00:00"),"Portland, OR, USA",123.00,true),
new Order(62,"Advanced Technology Systems",Convert.ToDateTime("2016-11-04T19:00:00"),"Los Angeles, CA, USA",24.00,true),
new Order(63,"Unosquare LLC",Convert.ToDateTime("2016-11-05T19:00:00"),"Guadalajara, JAL, Mexico",66.00,true),
new Order(64,"Vesta",Convert.ToDateTime("2016-11-10T19:00:00"),"Guadalajara, JAL, Mexico",35.00,false),
new Order(65,"Super La Playa",Convert.ToDateTime("2016-11-04T19:00:00"),"Guadalajara, JAL, Mexico",67.00,false),
new Order(66,"Advanced Technology Systems",Convert.ToDateTime("2016-11-09T19:00:00"),"Guadalajara, JAL, Mexico",18.00,true),
new Order(67,"Super La Playa",Convert.ToDateTime("2016-11-04T19:00:00"),"Leon, GTO, Mexico",42.00,true),
new Order(68,"Super La Playa",Convert.ToDateTime("2016-11-06T19:00:00"),"Leon, GTO, Mexico",0.00,false),
new Order(69,"Advanced Technology Systems",Convert.ToDateTime("2016-11-07T19:00:00"),"Leon, GTO, Mexico",66.00,false),
new Order(70,"Oxxo",Convert.ToDateTime("2016-11-05T19:00:00"),"Guadalajara, JAL, Mexico",6.00,false),
new Order(71,"Vesta",Convert.ToDateTime("2016-11-02T19:00:00"),"Portland, OR, USA",22.00,false),
new Order(72,"Advanced Technology Systems",Convert.ToDateTime("2016-11-05T19:00:00"),"Los Angeles, CA, USA",27.00,false),
new Order(73,"Advanced Technology Systems",Convert.ToDateTime("2016-11-05T19:00:00"),"Los Angeles, CA, USA",32.00,false),
new Order(74,"Super La Playa",Convert.ToDateTime("2016-11-10T19:00:00"),"Guadalajara, JAL, Mexico",64.00,true),
new Order(75,"Oxxo",Convert.ToDateTime("2016-11-05T19:00:00"),"Portland, OR, USA",62.00,false),
new Order(76,"Super La Playa",Convert.ToDateTime("2016-11-08T19:00:00"),"Leon, GTO, Mexico",58.00,true),
new Order(77,"Super La Playa",Convert.ToDateTime("2016-11-05T19:00:00"),"Portland, OR, USA",0.00,true),
new Order(78,"Microsoft",Convert.ToDateTime("2016-11-11T19:00:00"),"Los Angeles, CA, USA",0.00,false),
new Order(79,"Oxxo",Convert.ToDateTime("2016-11-06T19:00:00"),"Los Angeles, CA, USA",50.00,false),
new Order(80,"Oxxo",Convert.ToDateTime("2016-11-11T19:00:00"),"Guadalajara, JAL, Mexico",6.00,false),
new Order(81,"Advanced Technology Systems",Convert.ToDateTime("2016-11-02T19:00:00"),"Guadalajara, JAL, Mexico",255.00,false),
new Order(82,"Advanced Technology Systems",Convert.ToDateTime("2016-11-08T19:00:00"),"Guadalajara, JAL, Mexico",0.00,true),
new Order(83,"Oxxo",Convert.ToDateTime("2016-11-10T19:00:00"),"Guadalajara, JAL, Mexico",36.00,false),
new Order(84,"Advanced Technology Systems",Convert.ToDateTime("2016-11-08T19:00:00"),"Guadalajara, JAL, Mexico",4.00,true),
new Order(85,"Vesta",Convert.ToDateTime("2016-11-03T19:00:00"),"Leon, GTO, Mexico",74.00,false),
new Order(86,"Super La Playa",Convert.ToDateTime("2016-11-03T19:00:00"),"Guadalajara, JAL, Mexico",40.00,false),
new Order(87,"Oxxo",Convert.ToDateTime("2016-11-07T19:00:00"),"Portland, OR, USA",6.00,true),
new Order(88,"Vesta",Convert.ToDateTime("2016-11-04T19:00:00"),"Portland, OR, USA",64.00,true),
new Order(89,"Oxxo",Convert.ToDateTime("2016-11-04T19:00:00"),"Guadalajara, JAL, Mexico",75.00,true),
new Order(90,"Oxxo",Convert.ToDateTime("2016-11-08T19:00:00"),"Leon, GTO, Mexico",134.00,true),
new Order(91,"Unosquare LLC",Convert.ToDateTime("2016-11-10T19:00:00"),"Los Angeles, CA, USA",8.00,false),
new Order(92,"Super La Playa",Convert.ToDateTime("2016-11-08T19:00:00"),"Portland, OR, USA",56.00,true),
new Order(93,"Super La Playa",Convert.ToDateTime("2016-11-05T19:00:00"),"Los Angeles, CA, USA",189.00,true),
new Order(94,"Super La Playa",Convert.ToDateTime("2016-11-03T19:00:00"),"Portland, OR, USA",54.00,false),
new Order(95,"Vesta",Convert.ToDateTime("2016-11-08T19:00:00"),"Los Angeles, CA, USA",112.00,false),
new Order(96,"Advanced Technology Systems",Convert.ToDateTime("2016-11-04T19:00:00"),"Leon, GTO, Mexico",118.00,false),
new Order(97,"Oxxo",Convert.ToDateTime("2016-11-10T19:00:00"),"Portland, OR, USA",174.00,false),
new Order(98,"Unosquare LLC",Convert.ToDateTime("2016-11-10T19:00:00"),"Portland, OR, USA",15.00,false),
new Order(99,"Advanced Technology Systems",Convert.ToDateTime("2016-11-08T19:00:00"),"Guadalajara, JAL, Mexico",88.00,true),
new Order(100,"Unosquare LLC",Convert.ToDateTime("2016-11-09T19:00:00"),"Guadalajara, JAL, Mexico",0.00,false),

    };

    }
}
