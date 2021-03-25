class CustomError extends Error {
    constructor({ messege, data }) {
        super(message);
        this.data = data;

    }
}
try {
    console.log(name);
    const name = 'Donizete';
    const myError = new CustomError({
        messege: 'Custom message',
        data: {
            type: 'Server error'
        }
    });

    throw myError;
} catch (err) {
    
    console.log(err.data);
} finally {
    console.log('Keep going ...');
}

