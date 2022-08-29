# Numerize
Welcome to Numerize, the One, the Only the Undefeated library of C# that allows you to write numbers in plain English to use them in your code. 


![The Power Of NUMERIZE](assets/meme01.jpg?raw=true "The Power Of NUMERIZE")


## Install Numerize
You should install [Numerize with Nuget](https://www.nuget.org/packages/Numerize/1.0.0)
```
Install-Package Numerize
```
Or via the .NET core command line interface: 
```
dotnet add package Numerize
```


## Features
Are you not tired of having to hardcode ridiculously long numbers that take you 10 minutes to be sure they are okay? With Numerize, you have the perfect solution. Use plain English for them.

1. It allows to write very long numbers that are very hard to pronounce just with seeing them for example `43209412016`; Which number it is, ah? well with `Numerize` you will know straight away:
```c#
long value = Numerize.Fourty.Three().Billion()
                .Two().Hundred().Nine().Milion()
                .Four().Hundred().Twelve().Thousand()
                .Sixteen();
```
Of course it also works with smaller number.

2. The second feature consists in convert a number into a sentence that you can be printed for those PMs or POs that annoy you so much and they want everything in csv:
```c#
Numerize numerize = new Numerize();
string result = numerize.Fourty().Three().Billion()
                .Two().Hundred().Nine().Milion()
                .Four().Hundred().Twelve().Thousand()
                .Sixteen();
```
This will return the next sentence `forty three billion two hundred nine million four hundred twelve thousand sixteen`

With this such amazing feature you can emulate the amazing sentence from Dragon Ball:
```c#
string result = $"It's Over {Numerize.Nine.Thousand()}!";
```



### Decimals
To Be Done, right now it only works in possitive real numbers, but I plan to extend it to positive/negative and to decimals

## Contributions
Any idea to improve the functionality is welcome

## Give the project a star ⭐
If you like the project, don't hesitate to give it a star or economically support it by [donating a coffee](https://www.buymeacoffee.com/NetMentor)


**Disclaimer**: This library was created totally for the craic; I didn't even stop to think about performance.