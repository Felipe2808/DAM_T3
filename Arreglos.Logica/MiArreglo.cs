namespace Arreglos.Logica
{
    public class MiArreglo
    {
        private int _tope;
        private int[] _arreglo;
        
        public MiArreglo(int n)
        {
            N= n;
            _arreglo = new int[N];
            _tope = 0;

        }
        public int N { get;  }
        public bool EstaLleno => _tope == N;
        public bool EstaVacio => _tope == 0;
        public void Llenar(int minimo ,int maximo)
        {
            Random r = new Random();
            for (int i = 0; i < N; i++)
            {
                _arreglo[i] = r.Next(minimo, maximo);
              
            }
            _tope = N;
        }
        public void burbuja()
        {
                       burbuja(true);
        }

        public void burbuja(bool asendente)
        {
            for (int i = 0; i < _tope ; i++)
            {
                for (int j = i+1; j < _tope ; j++)
                {
                    if (asendente)
                    {
                        if (_arreglo[i] > _arreglo[j])
                        {
                            cambiar(ref _arreglo[i], ref _arreglo[j]);
                        }
                    }
                    else
                    {
                        if (_arreglo[i] < _arreglo[j])
                        {
                            cambiar(ref _arreglo[i], ref _arreglo[j]);
                        }
                    }
                   

                }
            }
            
        }
        public void asendente() { }


        private void cambiar( ref int a,ref int b)
        {
            int aux = a;
            a = b;
            b = aux;

        }
        public void agregar(int numero)
        {
            if (EstaLleno)

            {
                try
                {
                    throw new Exception("Arreglo lleno");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
               
            }
            else
            {
                _arreglo[_tope] = numero;
                _tope++;

            }
                
        }
        public void incertar(int numero,int pocision)
        {
            if (EstaLleno)
            {
                throw new Exception("el arreglo esta lleno");

                
            }
            if (pocision < 0)
            {
                pocision = 0;
            }
            if(pocision > _tope)
            {
                pocision = _tope;
            }
            for (int i = _tope; i > pocision; i--)
            {
                _arreglo[i] = _arreglo[i - 1];

            }
            
            _arreglo[pocision] = numero;

            _tope++;
        }
        public void eliminar(int pocision)
        {
            if (pocision < 0)
            {
                pocision = 0;
            }
            if (pocision > _tope)
            {
                pocision = _tope;
            }
            for (int i = pocision; i < _tope-1; i++)
            {
                _arreglo[i] = _arreglo[i + 1];
            }
            _tope--;



        }
            
        public override string ToString()
        {
            if (EstaVacio)
            {
                return "Arreglo vacio";
            }
            String salida =string.Empty;
            int cont = 0;
            for (int i = 0; i < _tope; i++)
            {
                salida += $"{_arreglo[i]} \t";
                cont++;
                if (cont >9)
                {
                    salida += "\n";
                    cont = 0;
                }


            }
            return salida;
        }



    }
}
