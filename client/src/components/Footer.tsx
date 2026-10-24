import './Footer.css'

function Footer() {
  const year = new Date().getFullYear()

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
