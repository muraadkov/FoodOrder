export class Meal {
    constructor(
        public mealId?: number,
        public name?: string,
        public type?: string,
        public weight?: number,
        public image?: string,
        public quantity?: number,
        public price?: number) { }
}