const Point = require('./Point.js');

/**
 * Class Area
 * Un "Point" est un objet représentant des coordonnées (x,y) dans un espace à 2 dimensions
 * Une "Area" est un objet représentant une zone à 2 dimensions (coïncidence?)
 * Une "Area" est obligatoirement définie par une largeur (nombre de colonnes) et une hauteur (nombre de lignes) pour former une grille.
 * On peut ajouter, déplacer et supprimer des "Point" à l'intérieur d'une Area (1 seul "Point" par coordonnée).
 * Une "Area" ne peut contenir plus de "Point" que de coordonnées disponibles dans la zone.
 * (une zone 4x4 est limitée à 16 points)
 * Les "Point" ajoutés peuvent se situer en dehors des limites de la zone (la limite du nombre de point par zone ne peut pas être dépassée !).
 * 
 * Le "Point" d'origine (0,0) d'une "Area" est situé au coin supérieur gauche
 * Le "Point" d'origine existe toujours (créé dans le constructeur) et ne peut être supprimé
 * A partir du "Point" d'origine, la zone s'étend vers la droite pour les abscisses et vers le bas pour les ordonnées
 *
 *
 * ALGORITHME AJOUTER/DEPLACER UN POINT DANS UNE AREA: 
 *
 * 1) En cas d'ajout, si la zone (Area) est pleine (Toutes les coordonnées "dans les limites" sont occupées par un "Point")
 *    1.1) Ajout impossible, renvoyer false
 *
 * 2) Si un "Point" existe déjà aux mêmes coordonnées:
 *    2.1) Rechercher la position libre la plus proche du "Point" d'origine (0,0)
 *    2.2) Si 2 positions son éligibles (distance égale), celle la plus proche du bord supérieur de la zone est privilégiée
 *       
 * 3) Enregistrer le "Point" dans la zone
 * 
 * 4) Renvoyer true
 */
class Area {
    /**
     * Constructeur: Initialise une nouvelle instance de la classe "Area"
     * La largeur et la hauteur définissent respectivement le nombre de colonnes et de lignes. 
     * @param int _width largeur de la zone
     * @param int _height hauteur de la zone
     */
    constructor(_width, _height) {
        // A vous de jouer
        this.width = parseInt(_width);
        this.height = parseInt(_height);
        this.point = new Array(this.height * this.width);
        //Array(parseInt(_width)).fill().map(x => Array(parseInt(_height)).fill());
    }

    /**
     * Ajoute un "Point" dans la zone
     * Le "Point" peut se trouver hors des limites de la zone
     * @param Point _point 
     * @returns Boolean true en cas de succès, false si l'ajout est impossible 
     */
    addPoint(_point) {
        if (!(_point instanceof Point)) {
            return false;
        }

        if (!this.point.includes(undefined)) {
            return false;
        }
        let l = this.width * this.height;
        let m = _point.y * this.width + _point.x;
        if (m < l && this.point[m] == undefined) {
            this.point.splice(m, 1, _point);
            return true;
        } else {
            for (let i = 0; i < l; i++) {
                if (this.point[i] == undefined) {
                    this.point.splice(i, 1, _point);
                    return true;
                }
            }
        }
    }



    /**
     * Déplace un point existant dans la zone vers de nouvelles coordonnées
     * Les nouvelles coordonnées peuvent se trouver hors limites
     * @returns Boolean true en cas de succès, false en cas d'échec
     */
    movePoint(_p1, _point) {
        if (!(_point instanceof Point)) {
            return false;
        }
        // implémenter la méthode
        let l = this.width * this.height;
        let m = _point.y * this.width + _point.x;
        let n = _p1.y * this.width + _p1.x;
        if (this.point[m] == undefined) {
            _p1.x = _point.x;
            _p1.y = _point.y;
            this.point.splice(m, 1, _p1);
            delete this.point[n];
            return true;
        } else {
            return false;
        }


    }


    /**
     * Vérifie la position de chaque "Point" existant dans la zone
     * Chaque Point hors des limites est automatiquement déplacé dans les limites vers la position libre la plus proche
     * @returns int le nombre de points déplacés
     */
    needAllInside() {
        // implémenter la méthode
        let nombre = 0;
        let l = this.width * this.height;
        for (let i = 0; i < l; i++) {
            if (this.point[i] != undefined) {
                if (this.point[i].x > this.width - 1 || this.point[i].y > this.height - 1) {
                    let m = this.point[i].y * this.width + this.point[i].x;
                    this.point[i].x = i % this.width;
                    this.point[i].y = Math.floor(i / this.width);
                    nombre += 1;
                }
            }
        }
        return nombre;
    }
}


/*
let A = new Area(6, 6);
//A[0] = p1;
console.log(A.point);
let p0 = new Point(2, 0);
let p1 = new Point(4, 3);
let p2 = new Point(2, 5);
let p3 = new Point(0, 5);
let p4 = new Point(2, 8);
let p5 = new Point(6, 0);
let p6 = new Point(6, 2);
let p7 = new Point(6, 2);

//console.log(p1.distance(p2));
A.addPoint(p1);
A.addPoint(p2);
A.addPoint(p3);
A.point[5] = 'xxx';
A.addPoint(p4);
A.addPoint(p6);
A.addPoint(p7);
A.addPoint(p0);
A.addPoint(p5);
console.log(A.point);
let p8 = new Point(3, 3);
A.movePoint(p1, p8);
console.log(A.point);
console.log();
console.log(A.needAllInside());
console.log(A.point);
*/

module.exports = Area;