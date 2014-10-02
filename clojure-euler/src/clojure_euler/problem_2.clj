(ns clojure-euler.problem-2
  (:gen-class))

(defn fibmax [max] 
  (take-while (partial > max) 
    (map first (iterate (fn [[a b]] [b (+ a b)]) [0 1]))))

(defn is-even [v] (= 0 (mod v 2)))

(defn get-evens [limit] (filter is-even (fibmax limit)))

(defn find-sum [limit] (reduce + (get-evens limit)))

(defn solve [] (find-sum 4000000))