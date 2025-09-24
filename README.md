# Anthem Sigma

A comprehensive cryptography education tool that implements classical cipher algorithms for learning and recreational use. Anthem Sigma provides an intuitive Windows Forms interface for both encryption/decryption operations and cryptanalysis techniques.

## 🎯 Features

### Encryption & Decryption
- **Caesar Cipher** - Classic shift cipher with customizable key
- **Keyword Cipher** - Substitution cipher using keyword-based alphabets with offset support
- **Affine Cipher** - Mathematical cipher using multiplicative and additive transformations
- **Vigenère Cipher** - Polyalphabetic cipher with repeating keyword
- **Hill Cipher** - Matrix-based cipher using 2×2 transformation matrices

### Cryptanalysis Tools
- **Letter Frequency Analysis** - Statistical analysis of character distribution
- **N-gram Analysis** - Pattern analysis for 2, 3, and 4-letter combinations
- **Monospace Display** - Proper formatting for cipher text examination

### User Experience
- **File Upload Support** - Import text files (.txt) for batch processing
- **Real-time Validation** - Dynamic UI updates based on input requirements
- **Multi-page Navigation** - Organized interface with dedicated sections for each feature
- **Educational Manual** - Built-in documentation and usage instructions

## 🛠️ Technical Details

- **Platform**: Windows (.NET Framework 4.7.2)
- **Language**: C# with Windows Forms
- **Architecture**: Form-based desktop application
- **File Support**: Text files (.txt) with UTF-8 encoding

## 📥 Download

**[Download Anthem Sigma v1.0.0](https://github.com/dpesall/Anthem-Sigma/releases/download/v1.0.0/Anthem.Sigma.exe)**

## 🚀 Getting Started

1. Download and run the executable
2. Choose your desired operation from the main menu:
   - **Encipher Text** - Encrypt plaintext using various algorithms
   - **Decipher Text** - Decrypt ciphertext with known parameters
   - **Utilities** - Perform cryptanalysis on unknown ciphers
   - **Manual** - View documentation and usage instructions
   - **Credits** - Application information

## 🔤 Supported Cipher Methods

| Cipher | Key Type | Description |
|--------|----------|-------------|
| **Caesar** | Single letter (A-Z) | Shifts each letter by a fixed amount |
| **Keyword** | Text + Offset | Creates substitution alphabet from keyword |
| **Affine** | Two integers | Uses formula: (ax + b) mod 26 |
| **Vigenère** | Text keyword | Repeating key for polyalphabetic substitution |
| **Hill** | 2×2 Matrix | Linear algebra transformation |

## 🎓 Educational Use

Anthem Sigma is designed for:
- **Cryptography Students** - Hands-on experience with classical ciphers
- **Computer Science Education** - Understanding encryption fundamentals
- **Puzzle Enthusiasts** - Solving cryptographic challenges
- **Security Awareness** - Learning historical encryption methods

## 🤝 Contributing

This project is open source and welcomes contributions. Areas for improvement include:
- Additional cipher implementations
- Enhanced cryptanalysis features
- UI/UX improvements
- Cross-platform compatibility

## 📄 License

Licensed under the MIT License. See [LICENSE](LICENSE) for details.

---

*Anthem Sigma - Making cryptography education accessible and engaging*
