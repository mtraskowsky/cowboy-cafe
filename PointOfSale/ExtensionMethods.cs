using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Media;

namespace CowboyCafe.Extensions
{
    public static class ExtensionMethods
    {
        /// <summary>
        /// Find the first ancestor in the Visual Tree that has the specified type,
        /// or null if no ancestor is found
        /// </summary>
        /// <typeparam name="T"> The type to search for </typeparam>
        /// <param name=""></param>
        /// <param name=""></param>
        /// <returns>The first ancestor of type T, or null</returns>
        public static T FindAncestor<T>(this DependencyObject obj) where T : DependencyObject // return some kind of node out of the component tree and return it as the type we are asking for (T)
        {
            var parent = VisualTreeHelper.GetParent(obj);
            if (parent == null) return null;

            if (parent is T) return parent as T; // return the parent as Type T

            return FindAncestor<T>(parent);
        }
    }
}
