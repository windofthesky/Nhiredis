﻿using System;
using System.Collections.Generic;

namespace Nhiredis
{
    public class Utils
    {
        public static object ConstructDictionary(List<string> values, Type typeHint)
        {
            // there is a good general way of doing this for sure,
            // but I'm in a rush :-)

            int count = values.Count % 2 == 0 ? values.Count : values.Count - 1;

            if (typeHint == typeof(Dictionary<string, string>))
            {
                var result = new Dictionary<string, string>();    
                for (int i = 0; i < count; i += 2)
                {
                    result.Add(values[i], values[i + 1]);
                }
                return result;
            }

            if (typeHint == typeof(Dictionary<string, long>))
            {
                var result = new Dictionary<string, long>();
                for (int i = 0; i < count; i += 2)
                {
                    result.Add(values[i], long.Parse(values[i + 1]));
                }
                return result;
            }

            if (typeHint == typeof(Dictionary<long, string>))
            {
                var result = new Dictionary<long, string>();
                for (int i = 0; i < count; i += 2)
                {
                    result.Add(long.Parse(values[i]), values[i + 1]);
                }
                return result;
            }

            if (typeHint == typeof(Dictionary<string, int>))
            {
                var result = new Dictionary<string, int>();
                for (int i = 0; i < count; i += 2)
                {
                    result.Add(values[i], int.Parse(values[i + 1]));
                }
                return result;
            }

            if (typeHint == typeof(Dictionary<int, string>))
            {
                var result = new Dictionary<int, string>();
                for (int i = 0; i < count; i += 2)
                {
                    result.Add(int.Parse(values[i + 1]), values[i]);
                }
                return result;
            }

            if (typeHint == typeof(Dictionary<long, int>))
            {
                var result = new Dictionary<long, int>();
                for (int i = 0; i < count; i += 2)
                {
                    result.Add(long.Parse(values[i]), int.Parse(values[i + 1]));
                }
                return result;
            }

            if (typeHint == typeof(Dictionary<int, long>))
            {
                var result = new Dictionary<int, long>();
                for (int i = 0; i < count; i += 2)
                {
                    result.Add(int.Parse(values[i]), long.Parse(values[i + 1]));
                }
                return result;
            }

            if (typeHint == typeof(Dictionary<int, int>))
            {
                var result = new Dictionary<int, int>();
                for (int i = 0; i < count; i += 2)
                {
                    result.Add(int.Parse(values[i]), int.Parse(values[i + 1]));
                }
                return result;                
            }

            // TODO: more cases

            return values;
        }
    }
}
