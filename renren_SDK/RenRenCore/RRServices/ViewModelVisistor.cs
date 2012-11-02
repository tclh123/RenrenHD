using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RenrenCore.Entities;
using RenrenCore.Models;

namespace RenrenCore.RRServices
{
  public  abstract class RRServiceVisistor<IdType, EntityType> where EntityType : PropertyChangedBase, INotifyPropertyChanged, new()
    {
        // Simple visit interface
        public abstract void Visit(RRServiceBase<IdType, EntityType> RRServiceBase);
        // Advanced visit interface
        public abstract Task<object> Visit(RRServiceBase<IdType, EntityType> RRServiceBase, params object[] args);
    }

    // Get the high quality album image
    // The visitor is album view model and album list view is the visiteer
    class HQAlbumImageVisitor : RRServiceVisistor<long, PhotoListEntity>
    {
        public override void Visit(RRServiceBase<long, PhotoListEntity> albumViewModel)
        {
            throw new NotImplementedException();
        }

        public async override Task<object> Visit(RRServiceBase<long, PhotoListEntity> albumViewModel, params object[] args)
        {
            if (args.Length < 2) throw new ArgumentException();

            AlbumListService albums = (AlbumListService)args[0];
            int uid = (int)args[1];

            if (albums[uid] == null) throw new ArgumentException();

            AlbumService albumView = albumViewModel as AlbumService;

            // replace all albums background image to hight quality
            foreach (var item in albums[uid].Album_list)
            {
                if (albumView[item.Id] == null)
                {
                    var response = await albumView.RequestPhotoListByAlbumId(item.User_id, item.Id, -1, -1, null);
                }

                if (albumView[item.Id] != null && albumView[item.Id].Photo_list != null)
                {
                    // Fetch the first image as the album image
                    item.LargeImage = albumView[item.Id].Photo_list[0].Img_large;
                }
                else
                {
                    item.LargeImage = item.Img;
                }
            }

            return albums;
        }
    }

    // Calculate the total shared friends, this is a example
    //class SharedFriendsVisitor : RRServiceVisistor<int, FriendListEntity>
    //{
    //    public override void Visit(RRServiceBase<int, FriendListEntity> RRServiceBase)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public override object Visit(RRServiceBase<int, FriendListEntity> RRServiceBase, params object[] args)
    //    {
    //        if (args.Length < 2) throw new ArgumentException(); 
    //        if (RRServiceBase is FriendsViewModel)
    //        {
    //            FriendListEntity result = new FriendListEntity();
    //            for (int i = 1; i < args.Length; i++)
    //            {
    //            }
    //            return result;
    //        }
    //        else
    //        {
    //            return 0;
    //        }
    //    }
    //}
}
