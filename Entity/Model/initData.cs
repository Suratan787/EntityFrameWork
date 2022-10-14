namespace Entity.Model
{
    public class initData
    {

        public static void GenData(CustomerContext db)
        {
            db.Database.EnsureCreated();
            if (db.Customer.Any())
            {
                //return;
            }
            customer cs = new customer();
            cs.name1 = "chanachai";
            cs.name2 = "benmat";
            cs.sex = "M";
            cs.age = 20;
            db.Customer.Add(cs);
            db.SaveChanges();

            customer cs2 = new customer();
            cs2.name1 = "patcharaphon";
            cs2.name2 = "Lertsitham";
            cs2.sex = "M";
            cs2.age = 40;
            db.Customer.Add(cs2);
            db.SaveChanges();

            customer cs3 = new customer();
            cs3.name1 = "pongsakorn";
            cs3.name2 = "nakwan";
            cs3.sex = "F";
            cs3.age = 18;
            db.Customer.Add(cs3);
            db.SaveChanges();

            customer cs4 = new customer();
            cs4.name1 = "pongsakorn";
            cs4.name2 = "nakwan";
            cs4.sex = "F";
            cs4.age = 18;
            db.Customer.Add(cs4);
            db.SaveChanges();

            customer cs5 = new customer();
            cs5.name1 = "peerasit";
            cs5.name2 = "chardkratok";
            cs5.sex = "F";
            cs5.age = 35;
            db.Customer.Add(cs5);
            db.SaveChanges();

            product pd = new product();
            pd.code = "112";
            pd.name1 = "Scone";
            pd.name2 = "สโคน";
            pd.price = 299;
            db.Product.Add(pd);
            db.SaveChanges();

            product pd2 = new product();
            pd2.code = "113";
            pd2.name1 = "Welsh_Cake";
            pd2.name2 = "เค้กเวลส์";
            pd2.price = 400;
            db.Product.Add(pd2);
            db.SaveChanges();

            product pd3 = new product();
            pd3.code = "114";
            pd3.name1 = "Trifle";
            pd3.name2 = "ไทรเฟิล";
            pd3.price = 420;
            db.Product.Add(pd3);
            db.SaveChanges();

            product pd4 = new product();
            pd4.code = "115";
            pd4.name1 = "Bacon";
            pd4.name2 = "เบคอน";
            pd4.price = 120;
            db.Product.Add(pd4);
            db.SaveChanges();

            product pd5 = new product();
            pd5.code = "116";
            pd5.name1 = "Cockles";
            pd5.name2 = "หอยแครง";
            pd5.price = 200;
            db.Product.Add(pd5);
            db.SaveChanges();

            Orderh orh = new Orderh();
            orh.doc_no = "112";
            orh.doc_date = new DateTime(2022, 01, 01);
            orh.amount = 299;
            orh.vat = 20.93;
            orh.net_amount = 319.93;
            orh.customerid = cs.id;
            db.Orderh.Add(orh);
            db.SaveChanges();

            Orderh orh2 = new Orderh();
            orh2.doc_no = "113";
            orh2.doc_date = new DateTime(2022, 01, 02);
            orh2.amount = 400;
            orh2.vat = 28;
            orh2.net_amount = 428;
            orh2.customerid = cs2.id;
            db.Orderh.Add(orh2);
            db.SaveChanges();

            Orderh orh3 = new Orderh();
            orh3.doc_no = "114";
            orh3.doc_date = new DateTime(2022, 01, 03);
            orh3.amount = 420;
            orh3.vat = 29.4;
            orh3.net_amount = 449.5;
            orh3.customerid = cs3.id;
            db.Orderh.Add(orh3);
            db.SaveChanges();

            Orderh orh4 = new Orderh();
            orh4.doc_no = "115";
            orh4.doc_date = new DateTime(2022, 01, 04);
            orh4.amount = 120;
            orh4.vat = 8.4;
            orh4.net_amount = 128.4;
            orh4.customerid = cs4.id;
            db.Orderh.Add(orh4);
            db.SaveChanges();

            Orderh orh5 = new Orderh();
            orh5.doc_no = "116";
            orh5.doc_date = new DateTime(2022, 01, 05);
            orh5.amount = 200;
            orh5.vat = 14;
            orh5.net_amount = 214;
            orh5.customerid = cs5.id;
            db.Orderh.Add(orh5);
            db.SaveChanges();

            orderid orid = new orderid();
            orid.orderhid = 456;
            orid.itemid = pd.id;
            orid.item_desc = "Scone";
            orid.price = 299;
            orid.qty = 3;
            orid.vat = 20.93;
            orid.net_amount = 917.93;
            db.Orderid.Add(orid);
            db.SaveChanges();

            orderid orid2 = new orderid();
            orid2.orderhid = 457;
            orid2.itemid = pd2.id;
            orid2.item_desc = "Welsh_Cake";
            orid2.price = 400;
            orid2.qty = 5;
            orid2.vat = 28;
            orid2.net_amount = 2028;
            db.Orderid.Add(orid2);
            db.SaveChanges();

            orderid orid3 = new orderid();
            orid3.orderhid = 458;
            orid3.itemid = pd3.id;
            orid3.item_desc = pd3.name1;
            orid3.price = 420;
            orid3.qty = 5;
            orid3.vat = 29.4;
            orid3.net_amount = 2129.4;
            db.Orderid.Add(orid3);
            db.SaveChanges();

            orderid orid4 = new orderid();
            orid4.orderhid = 459;
            orid4.itemid = pd4.id;
            orid4.item_desc = "Bacon";
            orid4.price = 120;
            orid4.qty = 2;
            orid4.vat = 8.4;
            orid4.net_amount = 848.4;
            db.Orderid.Add(orid4);
            db.SaveChanges();

            orderid orid5 = new orderid();
            orid5.orderhid = 4660;
            orid5.itemid = pd5.id;
            orid5.item_desc = "Cockles";
            orid5.price = 200;
            orid5.qty = 7;
            orid5.vat = 14;
            orid5.net_amount = 1414;
            db.Orderid.Add(orid5);
            db.SaveChanges();

        }
    }
}
