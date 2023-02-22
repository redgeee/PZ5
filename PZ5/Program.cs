Publisher publisher = new Publisher();
ConcreteSubscribers s = new ConcreteSubscribers();
publisher.Subscribe(s);


class ConcreteSubscribers : ISubscriber
{
    public void update<T>(T context)
    { }
}

interface ISubscriber
{
    public void update<T>(T context);
}


class Publisher
{
    private ISubscriber[] subscribers;
    private int mainState;

    public void Subscribe(ISubscriber s)
    { }

    public void Unsudscribe(ISubscriber s)
    { }

    public void NotifySubscribers()
    { }

    public void MainBusinessLogic()
    { }
}