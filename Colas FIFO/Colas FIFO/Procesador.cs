using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colas_FIFO
{
    class Procesador
    {
        private Proceso inicio=null, final=null;
        private int tProcesos = 0, ciclosNecesarios = 0;
        //Agregar
        public void push(Proceso p)
        {
            if (inicio != null)
            {
                final.siguente = p;
                final = p;
            }
            else
            {
                inicio = p;
                final = p;               
            }
            tProcesos++;
            ciclosNecesarios += p.ciclosProceso;
        }
        //Eliminar
        public void pop(int ciclosRestantes)
        {
            if (ciclosRestantes == 0)
            {
                inicio = inicio.siguente;
                tProcesos--;
            }
        }

        public int procesar()
        {
            int restantes;
            restantes = inicio.ciclosRestantes();
            ciclosNecesarios--;
            return restantes;
        }

        public int totalProcesosFinal()
        {
            return tProcesos;
        }

        public int ciclosNesesarios()
        {
            return ciclosNecesarios;
        }
        //total
        public Proceso verificarProcesos()
        {
            return inicio;
        }

   
    }
}
