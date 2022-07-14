﻿using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ColorManager : IColorService
    {
        //İş sınıfı, diğer iş sınıfları new'lemez. Bunun yerine _    //Ctor uygula.
        IColorDal _colorDal;
        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }
        public List<Color> GetAll()
        {

            return _colorDal.GetAll();
        }

        public Color GetById(int colorId)
        {
            return _colorDal.GetById(c => c.ColorId == colorId);
        }
    }
}
