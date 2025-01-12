def is_triangle(a, b, c):
    """
    Check if three sides can form a triangle.
    A triangle is valid if the sum of any two sides is greater than the third side.
    """
    return a + b > c and a + c > b and b + c > a

# Unit Tests
import unittest

class TestTriangleFunction(unittest.TestCase):
    def test_valid_triangle(self):
        """Test cases for valid triangles."""
        self.assertTrue(is_triangle(3, 4, 5))  # Right-angled triangle
        self.assertTrue(is_triangle(5, 5, 5))  # Equilateral triangle

    def test_invalid_triangle(self):
        """Test cases for invalid triangles."""
        self.assertFalse(is_triangle(1, 2, 3))  # Collinear sides
        self.assertFalse(is_triangle(0, 0, 0))  # Zero-length sides

    def test_negative_sides(self):
        """Test cases for negative side lengths."""
        self.assertFalse(is_triangle(-1, 2, 3))  # One side is negative

if __name__ == "__main__":
    unittest.main()
