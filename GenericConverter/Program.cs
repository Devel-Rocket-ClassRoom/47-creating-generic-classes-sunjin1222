using System;
using System.Collections.Generic;
using System.Reflection;

// README.md를 읽고 아래에 코드를 작성하세요.
Console.WriteLine("코드를 작성하세요.");


class Converter<TInput, TOutput>
{
    private Func<TInput, TOutput> _convertFunc;


    public Converter(Func<TInput, TOutput> input)
    {
        _convertFunc=input;
    }


    public TOutput Convert(TInput input)
    {
        if (input.TryGetValue())
        { 
        
        }

        return

    }
    public TOutput[] ConvertAll(TInput[] inputs)
    {
        return
    }

}