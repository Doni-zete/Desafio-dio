const assert = require('assert');
const Math = require('../test/Math');

describe( 'Math class', function(){
    it('Sum two numbers',function(){
        const Math = new Math();
        assert.equal(Math.sum (5,5),10);
});
});