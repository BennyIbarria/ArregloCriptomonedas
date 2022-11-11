namespace ArregloCripto
{
    class CriptoCoin
    {
        private string nombre;
        private string id;
        private float precio;
        private int arregloMoneda;

        public string Nombre 
        { 
            get{return nombre;} 
            set{nombre = value;}
        }
        public string ID 
        { 
            get{return id;} 
            set{id = value;} 
        }
        public float Precio 
        { 
            get{return precio;} 
            set{precio = value;} 
        }
        public void guardarMoneda()
        {
            CriptoCoin[] arregloMoneda = 
            {
                    new CriptoCoin(){Nombre = "Bitcoin", ID = "BTC", Precio=17563.45f},
                    new CriptoCoin(){Nombre = "Ethereum", ID = "ETH",Precio = 1297.74f},
                    new CriptoCoin(){Nombre = "Tether",ID = "USDT", Precio = 1.0f},
                    new CriptoCoin(){Nombre = "BNB", ID = "BNB",Precio = 302.90f},
                    new CriptoCoin(){Nombre = "USDCOIN", ID = "USDC", Precio = 1.0f},
                    new CriptoCoin(){Nombre = "BINANCEUSD", ID = "BUSD", Precio = 1.0f},
                    new CriptoCoin(){ Nombre = "XRP", ID = "XRP", Precio = 0.3962f},
                    new CriptoCoin(){Nombre = "Cardano", ID = "ADA", Precio = 0.3718f},
                    new CriptoCoin(){Nombre = "Dogecoin", ID = "DOGE", Precio = 0.09072f},   
            };
            int contador = 0;
            while(contador < arregloMoneda.Length)
            {
                Console.WriteLine($"La moneda {arregloMoneda[contador].Nombre} que tiene un ID {arregloMoneda[contador].ID} tienen un precio de {arregloMoneda[contador].Precio}");
                contador++;
            } 
        }
        
    }
}