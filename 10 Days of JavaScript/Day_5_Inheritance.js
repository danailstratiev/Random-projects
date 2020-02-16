class Rectangle {
    constructor(w, h) {
        this.w = w;
        this.h = h;
    }
}
Rectangle.prototype.area = function() {
    return this.w * this.h;
} ;

class Square extends Rectangle{
   constructor(s){
       super(s);
       this.w = s;
       this.h = s;
   }
}

const sqr = new Square(3);
    
console.log(sqr.area());