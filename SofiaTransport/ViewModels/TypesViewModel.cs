using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SofiaTransport.Models;

namespace SofiaTransport.ViewModels
{
    class TypesViewModel
    {
        private ObservableCollection<TypeModel> types;

        public IEnumerable<TypeModel> Types
        {
            get
            {
                if (this.types == null)
                {
                    this.Types = this.GetGeneratedTypes();
                }
                return this.types;
            }
            set
            {
                if (this.types != value)
                {
                    if (this.types == null)
                    {
                        this.types = new ObservableCollection<TypeModel>();
                    }
                    this.types.Clear();
                    foreach (var item in value)
                    {
                        this.types.Add(item);
                    }
                }
            }
        }

        public TypesViewModel()
        {
        }

        private IEnumerable<TypeModel> GetGeneratedTypes()
        {
            TypeModel[] types =
            {
                new TypeModel()
                {
                    Name = "Автобус",
                    ID = 1,
                    Buses=BusesViewModel.GetBuses()
                },
                new TypeModel()
                {
                    Name = "Тролей",
                    ID = 2,
                    Buses=TrolleysViewModel.GetTrolleys()
                },
                new TypeModel()
                {
                    Name = "Трамвай",
                    ID = 3,
                    Buses=TramsViewModel.GetTrams()
                },
            };
            return types;
        }
    }
}
