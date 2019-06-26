def prime(n):
    x = []
    for i in range(1,n+1):
        if i % 2 == 0 and i != 2 or i % 3 == 0 and i != 3 or i % 5 == 0 and i != 5 or i % 7 == 0 and i != 7:
            pass
        else:
            x.append(i)

    return " ".join(map(str,x))

def s_prime(n):
    if n < 2 :
        return True
    else:
        for i in range(2,n):
            if n % i == 0:
                return False
        return True

if __name__ == "__main__":
    print(prime(8))
    print(s_prime(2))
