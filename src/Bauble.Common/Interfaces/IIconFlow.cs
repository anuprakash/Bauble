﻿/*  This file is part of Bauble - http://bauble.codeplex.com
 *  Copyright (C) 2010-2012 Scott Blomfield
 *
 *  This program is free software: you can redistribute it and/or modify
 *  it under the terms of the GNU General Public License as published by
 *  the Free Software Foundation, either version 3 of the License, or
 *  (at your option) any later version.
 *
 *  This program is distributed in the hope that it will be useful,
 *  but WITHOUT ANY WARRANTY; without even the implied warranty of
 *  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 *  GNU General Public License for more details.
 *
 *  You should have received a copy of the GNU General Public License
 *  along with this program.  If not, see <http://www.gnu.org/licenses/>. 
 *
 *  Additional portions Copyright (C) (year) by (contributor)
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Input;

namespace Bauble.Common.Interfaces
{
    public interface IIconFlow
    {
        bool MouseMove(MouseEventArgs mouse, IBaubleButton activeButton, List<IBaubleButton> buttons);

        void Initialize(List<IBaubleButton> buttons);
        void Initialize(IBaubleButton button);
        void Uninitialize(List<IBaubleButton> buttons);

        bool Configurable { get; }
        string Name { get; set; }
        void Configure();
        string TypeName { get; }
    }

}
