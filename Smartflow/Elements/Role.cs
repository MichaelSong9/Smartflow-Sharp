﻿using Smartflow.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Dapper;

namespace Smartflow.Elements
{
    //Element
    public class Role : Element, IRelationShip
    {
        public string RNID
        {
            get;
            set;
        }

        internal override void Persistent()
        {
            string sql = "INSERT INTO T_ACTOR(NID,ID,RNID,NAME,INSTANCEID) VALUES(@NID,@ID,@RNID,@NAME,@INSTANCEID)";
            Connection.Execute(sql, new
            {
                NID=Guid.NewGuid().ToString(),
                RNID = RNID,
                ID = ID,
                NAME = NAME,
                INSTANCEID = INSTANCEID
            });

        }
    }
}
