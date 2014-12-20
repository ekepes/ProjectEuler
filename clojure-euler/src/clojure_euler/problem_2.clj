; To run:
;
; start the repl (lein repl)
; (use 'clojure-euler.problem-2)
; (solve-2)

(ns clojure-euler.problem-2
  (:gen-class))

(defn fibmax
  "creates the fibonaci series where the last element is less than the max" 
  [max] 
  (take-while (partial > max) 
              (map first (iterate (fn [[a b]] [b (+ a b)]) [0 1]))))

(defn is-even
  "returns true if v is even" 
  [v]
  (= 0 (mod v 2)))

(defn get-evens 
  "creates a sequence of the even values of the fibonaci series up to the limit"
  [limit] 
  (filter is-even (fibmax limit)))

(defn find-sum 
  "finds the sum of the even values of the fibonaci series up to the limit"
  [limit] 
  (reduce + (get-evens limit)))

(defn solve-2
  "solves the Project Euler problem"
  [] 
  (find-sum 4000000))