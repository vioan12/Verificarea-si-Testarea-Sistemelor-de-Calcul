#include <stdio.h>

int main() {
    int a, b, c, d, e, min;
    printf("a=");
    scanf("%d", &a);
    printf("b=");
    scanf("%d", &b);
    printf("c=");
    scanf("%d", &c);
    printf("d=");
    scanf("%d", &d);
    printf("e=");
    scanf("%d", &e);
    min = a;
    if (b < min) {
        min = b;
        if (c < min) {
            min = c;
            if (d < min) {
                min = d;
                if (e < min) {
                    min = e;
                    printf("min=%d", min);
                    return 0;
                } else {
                    printf("min=%d", min);
                    return 0;
                }
            } else {
                if (e < min) {
                    min = e;
                    printf("min=%d", min);
                    return 0;
                } else {
                    printf("min=%d", min);
                    return 0;
                }
            }
        } else {
            if (d < min) {
                min = d;
                if (e < min) {
                    min = e;
                    printf("min=%d", min);
                    return 0;
                } else {
                    printf("min=%d", min);
                    return 0;
                }
            } else {
                if (e < min) {
                    min = e;
                    printf("min=%d", min);
                    return 0;
                } else {
                    printf("min=%d", min);
                    return 0;
                }
            }
        }
    } else {
        if (c < min) {
            min = c;
            if (d < min) {
                min = d;
                if (e < min) {
                    min = e;
                    printf("min=%d", min);
                    return 0;
                } else {
                    printf("min=%d", min);
                    return 0;
                }
            } else {
                if (e < min) {
                    min = e;
                    printf("min=%d", min);
                    return 0;
                } else {
                    printf("min=%d", min);
                    return 0;
                }
            }
        } else {
            if (d < min) {
                min = d;
                if (e < min) {
                    min = e;
                    printf("min=%d", min);
                    return 0;
                } else {
                    printf("min=%d", min);
                    return 0;
                }
            } else {
                if (e < min) {
                    min = e;
                    printf("min=%d", min);
                    return 0;
                } else {
                    printf("min=%d", min);
                    return 0;
                }
            }
        }
    }
}