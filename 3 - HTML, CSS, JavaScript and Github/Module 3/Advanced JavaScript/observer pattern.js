class Subject {
    constructor() {
        this.observers = [];
    }

    subscribe(observer) {
        this.observers.push(observer);
    }

    unsubscribe(observer) {
        this.observers = this.observers.filter(obs => obs !== observer);
    }

    notify() {
        this.observers.forEach(observer => observer.update());
    }
}

class Observer {
    constructor(name) {
        this.name = name;
    }

    update() {
        console.log(`${this.name} received notification!`);
    }
}

const subject = new Subject();
const observer1 = new Observer('Observer 1');
const observer2 = new Observer('Observer 2');
subject.subscribe(observer1);
subject.subscribe(observer2);
subject.notify();