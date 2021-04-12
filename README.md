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

```
 public abstract class Bridge<Resource, Product>
    {
        protected readonly Resource resource;

        public Bridge(Resource resource)
        {
            this.resource = resource;
        }

        public abstract Product Build();
}
```



