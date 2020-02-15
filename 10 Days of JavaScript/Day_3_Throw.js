function isPositive(a) {       
        if (+a > 0) {
            console.log('YES');        
        }else if (+a === 0) {
            throw ('Zero Error');        
        }else{
            throw ('Negative Error');
        }       
}

