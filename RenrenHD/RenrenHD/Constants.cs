using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RenrenHD
{
    public class Constants
    {
        /// <summary>
        /// sidebar 选项列表
        /// </summary>
        static public List<View> ViewList = new List<View>
        {
            new View() { Title = "新鲜事", ClassType = typeof(RenrenHD.Views.FeedView)}
        };
    }

    /// <summary>
    /// View类
    /// </summary>
    public class View
    {
        public string Title { get; set; }

        public Type ClassType { get; set; }

        public override string ToString()
        {
            return Title;
        }
    }
}
