using System;
using System.Collections.Generic;
using System.Numerics;

namespace LabDev
{

    class Model
    {
        //private View view;
        List<PostData> PostsData;

        public delegate List<PostData> GetPostData();

        ModelLog modelLog;

        public List<PostData> GetAllPostData()
        {
            return PostsData;
        }
        public ModelLog ModelLog { get => modelLog; set => modelLog = value; }

        

        public void RegistarLog(string error)
        {
            ModelLog.ErrorLog(error);
        }
    }
}
