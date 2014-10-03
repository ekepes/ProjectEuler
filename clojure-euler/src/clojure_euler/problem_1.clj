(ns clojure-euler.problem-1
  (:gen-class))

(defn is-divisible 
  "determines if v id evenly divisible by d"
  [v d] 
  (= 0 (mod v d)))

(defn is-multiple 
  "determines if v is divisible by 3 or by 5 (or both)"
  [v] 
  (or (is-divisible v 3) (is-divisible v 5)))

(defn get-multiples 
  "finds all of the values divisible by 3, 5, or both up to the limit"
  [limit] 
  (filter is-multiple (range 1 limit)))

(defn find-sum 
  "determines the sum of all values divisible by 3, 5, or both up to the limit"
  [limit] 
  (reduce + (get-multiples limit)))

(defn solve 
  "solves the Project Euler problem"
  [] 
  (find-sum 1000))
