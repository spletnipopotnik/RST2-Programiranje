﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ObjektniKoncepti.Extensions
{
    /// <summary>
    /// Arh, Q33
    /// Razširitvene metode nam omogočijo razširiti funkcionalnosti objektov
    /// po naši meri, brez implementacije podrazreda
    /// </summary>
    public static class ExtensionsClass
    {
        public static bool ContainsVowels(this string str)
        {
            if (str.Contains('a') || str.Contains('e') || str.Contains('i') || str.Contains('o') || str.Contains('u'))
                return true;
            return false;
        }

        /// <summary>
        /// Dodamo razširitveno metode za naše (lokalne) potrebe
        /// </summary>
        public static bool IsWhite(this ChessBoardField field)
        {
            return (field.X + field.Y) % 2 == 0 ? false : true;
        }

        /// <summary>
        /// Metoda poskuša povoziti obstoječo metodo ToString.
        /// Prevajalnik nam to dovoli
        /// </summary>
        public static string ToString(this ChessBoardField field)
        {
            return $"[{field.X}:{field.Y}]";
        }

        // Dodajmo metodo za izpis elementov seznama.
    }

    public struct ChessBoardField
    {
        /// <summary>
        /// Vodoravna koordinata
        /// </summary>
        public int X { get; set; }

        /// <summary>
        /// Navpična koordinata
        /// </summary>
        public int Y { get; set; }

        public override string ToString()
        {
            return $"({this.X},{this.Y})";
        }
    }

}
