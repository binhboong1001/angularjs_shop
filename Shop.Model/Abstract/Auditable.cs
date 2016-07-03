using System;
using System.ComponentModel.DataAnnotations;

namespace Shop.Model.Abstract
{
    public class Auditable :IAuditable
    {

        public DateTime? CreatedDate
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }
        [MaxLength(256)]
        public string CreatedBy
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public DateTime? UpdateDate
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }
        [MaxLength(256)]
        public string UpdateBy
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }
    }
}
