# Design patterns made easy

I will add all design patterns I can as long as I learn them.

Feel free to help to improve any of them.

* Bridge
* LogChain
* Pipe
* StateMachine


## Bridge
The bridge pattern is suitable to intersect a set of classes A (bridges) to a set of classes B (implementators). Let's suppose you have 5 classes of the set A and 10 classes of the set B. The product of them is 5 * 10 = 50 combinations. So, by just implementing 5 bridges in one side and 10 implementations in the other side, you can call any bridge from the set A passing in the constructor any implementator of the set B, beeing able to make all the 50 different combinations as it pleases.

Basicaly, any class of set A will extends the Bridge and implement the methods of the bridge, in this case, only the Build. And any bridge can accept any resource, being the resource simply an interface. So, when you instanciate a bridge, you just call the "real" resource in the constructor of the bridge.

![image](https://user-images.githubusercontent.com/7969024/114333339-73429680-9b1e-11eb-9049-d9ee31c3dcb8.png)

And, of course, the implementators (the guys from the set B), each of them, will have the full set of tools required by any bridge to do its work. The bridge A will require some methods or whatever, the bridge B other methods, and so on.

## StateMachine
State machine is suitable to choose always the correct behavior of an object to all possible paths depending on its own state. The more states the object have, and if for each state of the object it's required a different behavior when it's hitted, so the state machine is the perfect design to you.

Basically, you can build a table to represent all the states of an object by crossing the States and the Actions. So, if your 'machine' can have 5 states and also can have 4 actions, then you will have to handle 5x4 = 20 different paths. If you do it using ifs or switches, believe me, it's gonna be a nightmare and highly prone to error.


## LogChain
This pattern is basically a pattern of the type PIPE, that you can use to do any log you like (to a file, to the console, to an API, to an email, etc.) by just calling a single line of code. You log once, the application log in every log you put in the PIPE.

## Adapter

The adapter code is self explanatory. Usually, it's a class that hides the differences of operation of another class or interface to simplify / obey the protocol / interface that the clients are used to.

![image](https://user-images.githubusercontent.com/7969024/114332649-fe229180-9b1c-11eb-91cf-439d7105fc89.png)

The chainned method's has nothing to do with adapter. Just did it to look cooler in the picture.


