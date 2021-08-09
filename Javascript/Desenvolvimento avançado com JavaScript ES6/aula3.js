//**introdução a Generators
//symbols

const uniqueId = Symbol('Hello');
const uniqueId = Symbol('Hello');

const obj = {
    [uniqueId]: 'Hello'
};

console.log(obj);
const uniqueId = Symbol('Hello');

//Well know symbols
Symbol.iterator;

const arr = [1, 2, 3, 4];
const str = 'Digital Invnovation One';

const obj = {
    values: [1, 2, 3, 4],
    [Symbol.iterator]() {
        let i = 0;

        return {
            next: () => {
                i++;
                return {
                    value: this.values[i - 1],
                    done: i > this.values.length
                };
            }
        };
    }
};

// generators

function* Hello() {
    console.log('Hello');
    yield;

    console.log('From');
    yield;

    console.log('value');

}

const it = Hello();


console.log(it.next());
console.log(it.next());
console.log(it.next('Outside'));