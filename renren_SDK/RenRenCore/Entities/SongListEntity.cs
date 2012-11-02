using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using RenrenCore.Models;
using System.Collections.ObjectModel;

namespace RenrenCore.Entities
{
    [DataContract]
    public class SongListEntity : PropertyChangedBase
    {
        [DataMember]
        private ObservableCollection<SongEntity> songs = new ObservableCollection<SongEntity>();
        public ObservableCollection<SongEntity> Songs
        {
            get
            {
                return songs;
            }
            set
            {
                songs = value;
                this.NotifyPropertyChanged(entity => entity.Songs);
            }
        }
    }
}
