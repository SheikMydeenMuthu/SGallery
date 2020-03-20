using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace SGallery.Model
{
    [DataContract]
    public class ImageList
    {
        [DataMember(Name = "photos")]
        public List<string> Photos = null;
    }

}
