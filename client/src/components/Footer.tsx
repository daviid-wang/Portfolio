import './Footer.css'

const year = new Date().getFullYear()

function Footer() {
  return (
    <footer className="container footer-wrap">
      <div className="footer">
        <p className="footer-text">{year} David Wang</p>
        <p className="footer-text">
          Based in Perth, Western Australia · Open to relocation
        </p>
      </div>
    </footer>
  )
}

export default Footer
