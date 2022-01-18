namespace stack1._1
{
    public class Pilha
    {
        private int valores[];
        private int topo;

        public Pilha()
        {
            valores = new int[10];
            topo = -1;
        }

        public void push(int elemento)
        {
            topo++;
            valores[topo] = elemento;
        }

        public bool isEmpty()
        {
            return (topo == -1);
        }

        public bool isFull()
        {
            return (topo == 9);
        }

        public int pop()
        {
            int element = valores[topo];
            topo--;
            return element;
        }
    }
}