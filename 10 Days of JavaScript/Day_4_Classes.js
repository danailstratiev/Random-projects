class Polygon{
    constructor(sides){
        this.sides = sides;
    }

    perimeter(){
          let sum = 0;
          for (const side of this.sides) {
              sum += side;
          }  
          return sum;
    }
}

let triangle = new Polygon([3, 4, 5]);

// Print the perimeter
console.log(triangle.perimeter());