import DOMPurify from "dompurify";

export interface Email {
  id: number;
  sender: string;
  subject: string;
  body: string;
  isPhishing: boolean;
  difficulty: number;
  displayLink: string;
  hiddenLink: string;
  contactNumber: string;
  footer: string;
  signature: string;
  isRead: boolean;
}

export const populateEmailBody = (body: string, email: Email): string => {
  return body
    .replace(/{{hiddenLink}}/g, email.hiddenLink)
    .replace(/{{displayLink}}/g, email.displayLink)
    .replace(/{{contactNumber}}/g, email.contactNumber)
    .replace(/{{footer}}/g, email.footer)
    .replace(/{{signature}}/g, email.signature);
};

export const sanitizeHtml = (html: string): string => {
  return DOMPurify.sanitize(html, {
    FORCE_BODY: true,
    ALLOWED_ATTR: ["style", "class", "type", "href", "rel", "target"],
    ALLOWED_TAGS: ["link","a", "button","br","p","h1","b","div"]
  });
};