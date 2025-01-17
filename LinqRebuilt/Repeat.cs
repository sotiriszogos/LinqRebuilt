﻿using System;
using System.Collections.Generic;

namespace LinqRebuilt
{
  public static partial class Enumerable
  {
    public static IEnumerable<TResult> Repeat<TResult>(TResult element, int count) {
      if (count < 0)
        throw new ArgumentOutOfRangeException(nameof(count));
      return RepeatImplementation(element, count);
    }

    private static IEnumerable<TResult> RepeatImplementation<TResult>(TResult element, int count) {
      for (int i = 0; i < count; i++) {
        yield return element;
      }
    }
  }
}