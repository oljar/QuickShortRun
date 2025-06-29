using CrudOwn.Model;
using CrudOwn.Services;
using CrudOwn.Widok;
using Kolory_WPF.ModelWidoku;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Xml.Linq;

namespace CrudOwn.ModelWidoku
{
    public class edycjaElementOne : ObservedObject
    {
        public elementOne model = new elementOne("");

        

        public string sciezka
        {
            get
            {
                return model.sciezka;
            }
            set
            {
                model.sciezka = value;
                onPropertyChanged(nameof(sciezka));
            }
        }

        public string witryna
        {
            get
            {
                return model.witryna;
            }
            set
            {
                model.witryna = value;
                onPropertyChanged(nameof(witryna));
            }
        }

        public edycjaElementOne()
        {
            this.sciezka = Jump.PobierzSciezke();
            this.witryna = Jump.PobierzWitryne();
        }


    }
}

            
            
        
        


            

            
            
        
      









    



    









