using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codigo2024Clase24
{
    public class MainWindowViewModel : ViewModelBase
    {


        #region Propiedades

        private int _Valor1;
        public int Valor1
        {
            get { return _Valor1; }
            set
            {
                _Valor1 = value;
                OnPropertyChanged(nameof(Valor1));
            }
        }


        private int _Valor2;
        public int Valor2
        {
            get { return _Valor2; }
            set
            {
                _Valor2 = value;
                OnPropertyChanged(nameof(Valor2));
            }
        }


        private int _ResultadoSuma;
        public int ResultadoSuma
        {
            get { return _ResultadoSuma; }
            set
            {
                _ResultadoSuma = value;
                OnPropertyChanged(nameof(ResultadoSuma));
            }
        }


        private int _ResultadoResta;
        public int ResultadoResta
        {
            get { return _ResultadoResta; }
            set
            {
                _ResultadoResta = value;
                OnPropertyChanged(nameof(ResultadoResta));
            }
        }

        private double _ResultadoCuadrado;
        public double ResultadoCuadrado
        {
            get { return _ResultadoCuadrado; }
            set
            {
                _ResultadoCuadrado = value;
                OnPropertyChanged(nameof(ResultadoCuadrado));
            }
        }


        private double _ResultadoPotencia;
        public double ResultadoPotencia
        {
            get { return _ResultadoPotencia; }
            set
            {
                _ResultadoPotencia = value;
                OnPropertyChanged(nameof(ResultadoPotencia));
            }
        }



        #endregion


        #region Comandos

        public RelayCommand SumarCommand { get; }

        public RelayCommand RestarCommand { get; }

        public RelayCommand ElevarCuadradoCommand { get; }

        public RelayCommand<string> ElevarPotenciaCommand { get; }


        #endregion


        public MainWindowViewModel()
        {            
            SumarCommand = new RelayCommand(Sumar);
            RestarCommand = new RelayCommand(Restar);
            ElevarCuadradoCommand = new RelayCommand(ElevarCuadrado);

            ElevarPotenciaCommand = new RelayCommand<string>((s) => ElevarPotencia(s));

        }


        private void Sumar()
        {
            
            ResultadoSuma = Valor1 + Valor2;
        }
      
        private void Restar()
        {
            ResultadoResta = Valor1 - Valor2;
        }
        private void ElevarCuadrado()
        {
            ResultadoCuadrado = Math.Pow(Valor1, 2);
        }

        private void ElevarPotencia(string potencia)
        {
            int potenciaInt = Convert.ToInt32(potencia);
            ResultadoPotencia = Math.Pow(Valor1, potenciaInt);
        }



    }
}
