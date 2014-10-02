(ns clojure-euler.problem-1
  (:gen-class))

(defn is-divisible [v d] (= 0 (mod v d)))

(defn is-multiple [v] (or (is-divisible v 3) (is-divisible v 5)))

(defn get-multiples [limit] (filter is-multiple (range 1 limit)))

(defn find-sum [limit] (reduce + (get-multiples limit)))

(defn solve [] (find-sum 1000))
